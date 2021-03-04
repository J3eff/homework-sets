using System;
using System.Collections.Generic;

namespace ExercicioPropostio.Entities
{
    class OnlineCoursePortal
    {
        public int UniqueCode { get; set; }

        public OnlineCoursePortal(int uniqueCode)
        {
            UniqueCode = uniqueCode;
        }

        public override int GetHashCode()
        {
            return UniqueCode.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if(!(obj is OnlineCoursePortal))
            {
                return false;
            }
            OnlineCoursePortal other = obj as OnlineCoursePortal;
            return UniqueCode.Equals(other.UniqueCode);
        }


    }
}
