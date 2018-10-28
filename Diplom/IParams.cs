using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Diplom
{
    public interface IParams
    {
        TypeOfWeb Type { get;}

        double TimeToRun { get;}

        double TimeToSearch { get;}

        double AmoutOfRecords { get;}

        int R { get; }

        void Calc();
    }
}
