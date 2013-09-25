// -----------------------------------------------------------------------
// <copyright file="IController.cs" company="">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace Controller.Abstract
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using DAL.Abstract;

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public interface IController
    {
        void Start(int threadCount);
        void Stop();
        void InsertToDatabase(IGeneratedData data);
    }
}
