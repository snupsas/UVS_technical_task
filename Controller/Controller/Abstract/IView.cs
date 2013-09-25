// -----------------------------------------------------------------------
// <copyright file="IForm.cs" company="">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace Controller.Abstract
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public interface IView
    {
        void AddToListView(IGeneratedData data);
        void ShowErrorMessage(Exception ex);
        void EnableStartButton();
        void DisableStartButton();
        void EnableStopButton();
        void DisableStopButton();
    }
}
