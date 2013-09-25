namespace Controller.Concrete
{
    using System;
    using Abstract;
    using Controller.Infrastructure;
    using System.Threading;

    public class Worker
    {
        const int sleepTimeFrom = 500;
        const int sleepTimeTo = 2001;

        private volatile bool stopFlag;

        public delegate void GeneratedDataHandler(IGeneratedData data);
        public event GeneratedDataHandler DataGeneration;
        private Random rnd;

        public Worker(int seed)
        {
            rnd = new Random(seed * (int)DateTime.Now.Ticks);
        }

        public void StartWork()
        {
            while (!stopFlag)
            {
                System.Threading.Thread.Sleep(rnd.Next(sleepTimeFrom, sleepTimeTo));
                var generatedString = RandomTextGenerator.GetRandomString(rnd.Next());
                OnDataGeneration(new GeneratedData { ThreadID = Thread.CurrentThread.Name, Data = generatedString, Time = DateTime.Now });
            }
        }

        protected void OnDataGeneration(IGeneratedData data)
        {
            if (DataGeneration != null)
            {
                DataGeneration(data);
            }
        }

        public void StopWork()
        {
            stopFlag = true;
        }        
    }
}
