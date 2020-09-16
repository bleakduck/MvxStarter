using System;
using System.Collections.Generic;
using System.Text;

namespace MvxStarter.Core.Services
{
    public interface IPropabilityDeterminer
    {
        int CalculateLuckiness();

        int DetermineLuckyNumber();
    }
}
