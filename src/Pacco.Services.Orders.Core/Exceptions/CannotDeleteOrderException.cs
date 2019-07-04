using System;

namespace Pacco.Services.Orders.Core.Exceptions
{
    public class CannotDeleteOrderException : ExceptionBase
    {
        public override string Code => "cannot_delete_order";
        public Guid Id { get; }

        public CannotDeleteOrderException(Guid id) : base($"Order with id: '{id}' cannot be deleted.")
        {
            Id = id;
        }
    }
}