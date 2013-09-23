using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL.Abstract
{
    public interface IRepository
    {
        void Create(int threadID, string generatedData, DateTime generationDate);
    }
}
