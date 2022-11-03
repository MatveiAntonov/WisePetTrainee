using System;
using MediatR;
using Organizations.Domain.Entities;

namespace Organizations.Application.OrganizationHandling.Commands.CreateOrganization {
    internal class CreateOrganizationCommandHandler 
        :IRequestHandler<CreateOrganizationCommand, int>{

        public async Task<int> Handle(CreateOrganizationCommand request,
            CancellationToken cancellationToken) {
            //var organization = new Organization {

            //};

            throw new NotImplementedException();
        }
    }
}
