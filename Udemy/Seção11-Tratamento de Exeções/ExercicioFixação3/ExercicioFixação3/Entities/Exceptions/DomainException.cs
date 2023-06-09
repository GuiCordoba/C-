using System;


namespace ExercicioFixação3.Entities.Exceptions
{
    internal class DomainException : ApplicationException
    {
        public DomainException(string mesaage) : base (mesaage)
        {

        }
    }
}
