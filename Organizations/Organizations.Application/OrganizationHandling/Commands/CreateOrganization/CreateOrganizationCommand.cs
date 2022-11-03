using System;
using MediatR;

namespace Organizations.Application.OrganizationHandling.Commands.CreateOrganization {
    internal class CreateOrganizationCommand : IRequest<int> {
        public string Title { get; set; }
        public int? Chain_Id { get; set; }
        public byte Organization_Category_Id { get; set; }
    }
}
