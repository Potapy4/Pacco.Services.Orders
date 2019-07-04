using System;
using Convey.CQRS.Commands;

namespace Pacco.Services.Orders.Application.Commands
{
    [Contract]
    public class ApproveOrder : ICommand
    {
        public Guid Id { get; }

        public ApproveOrder(Guid id)
        {
            Id = id;
        }
    }
}