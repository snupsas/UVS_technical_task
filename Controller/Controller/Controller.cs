using System;
using System.Collections.Generic;
using System.Threading;
using Controller.Abstract;
using Controller.Concrete;
using Controller.Infrastructure;
using DAL.Abstract;

namespace Controller
{
    public class ControllerClass : IController
    {
        IView view;
        IRepository repository;
        List<Thread> threads;
        List<Worker> workers;
        private Object threadLock = new Object();

        public ControllerClass(IView view, IRepository repository)
        {
            this.view = view;
            this.repository = repository;
            threads = new List<Thread>();
            workers = new List<Worker>();
            view.DisableStopButton();
        }

        public void Start(int threadCount)
        {
            view.DisableStartButton();
            threads.Clear();
            for (int i = 1; i <= threadCount; i++)
            {
                var worker = new Worker(i);
                worker.DataGeneration += (IGeneratedData data) => { view.AddToListView(data); };
                worker.DataGeneration += (IGeneratedData data) => { InsertToDatabase(data); };
                workers.Add(worker);

                var thread = new Thread(worker.StartWork);
                thread.Name = i.ToString();
                threads.Add(thread);
            }

            foreach (var thread in threads)
            {
                thread.Start();
            }
            view.EnableStopButton();
        }

        public void Stop()
        {
            view.DisableStopButton();
            foreach (var worker in workers)
            {
                worker.StopWork();
            }
            view.EnableStartButton();
        }

        private void FaultHandler()
        {
            this.Stop();
            foreach (var thread in threads)
            {
                if (Thread.CurrentThread != thread)
                {
                    thread.Abort();
                }
            }
        }

        public void InsertToDatabase(IGeneratedData data)
        {
            lock (threadLock)
            {
                try
                {
                    repository.Create(data.ThreadID, data.Data, data.Time);
                }
                catch (Exception ex)
                {
                    ErrorLogger.Log(ex);
                    view.ShowErrorMessage(ex);
                    this.FaultHandler();
                }  
            }   
        }
    }
}
