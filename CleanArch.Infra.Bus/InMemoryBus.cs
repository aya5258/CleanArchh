using CleanArch.Domain.Core.Bus;
using CleanArch.Domain.Core.Commands;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Infra.Bus
{
    public sealed class InMemoryBus :IMediatorHandler
    {

        private readonly IMediator _Mediator;
        public InMemoryBus(IMediator mediator)
        {
            _Mediator = mediator;
        }

        public Task SendCommand<T>(T command) where T : Command
        {
            return _Mediator.Send(command);
        }
    }
}
