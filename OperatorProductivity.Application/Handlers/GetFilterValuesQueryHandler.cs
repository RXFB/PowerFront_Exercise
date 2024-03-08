using MediatR;
using OperatorProductivity.Application.DTO;
using OperatorProductivity.Application.Queries;
using OperatorProductivity.Data;

namespace OperatorProductivity.Application.Handlers;

public class GetFilterValuesQueryHandler : IRequestHandler<GetFilterValuesQuery, FilterValuesDTO>
{
    private IChatRepository chatRepository;

    public GetFilterValuesQueryHandler(IChatRepository chatRepository)
    {
        this.chatRepository = chatRepository;
    }

    public Task<FilterValuesDTO> Handle(GetFilterValuesQuery request, CancellationToken cancellationToken)
    {
        var websites = chatRepository.GetWebsites();
        var devices = chatRepository.GetDevices();

        var filterValuesDTO = new FilterValuesDTO
        {
            Websites = websites.ToList(),
            Devices = devices.ToList()
        };
        return Task.FromResult(filterValuesDTO);
    }
}
