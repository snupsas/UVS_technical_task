// -----------------------------------------------------------------------
// <copyright file="GeneratedData.cs" company="">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace Controller.Concrete
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Abstract;

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public class GeneratedData : EventArgs, IGeneratedData
    {
        public string ThreadID { get; set; }
        public string Data { get; set; }
        public DateTime Time { get; set; }
    }
}
