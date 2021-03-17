using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QualityCheckDemo
{
    public enum OfflineType
        {
            Normal=1 , 
            NG = 2 ,
            Repair = 3 , 
            Scrap = 4  ,
            Restruct = 5 ,
            Concession =6 
        }

        public enum ProcedureFirstStatus
        {
            Qualified = 1 ,
            Concession = 2  ,
            Repair = 3 ,
            Scrap = 4 , 
            NG = 5 
        }

        public enum CheckTaskState
        {
            NotOnline = 1 , 
            InExecution = 2 ,
            Completed = 3
        }

        public enum CheckReason
        {
            First = 1, 
            LastPieceNotGood = 2 , 
            MeetFrequency = 3, 
            Repair = 4 , 
            LastProcedure = 5 , 
            Bad = 6
        }

        public enum CheckType
        {
            SelfCheck = 1 , 
            ThreeCoordinate = 2, 
            Manual = 3, 
            RawMaterialOpen = 4 , 
            OutSourcingOpen = 5 , 
            SquareMaterialOpen = 6
        }
}
