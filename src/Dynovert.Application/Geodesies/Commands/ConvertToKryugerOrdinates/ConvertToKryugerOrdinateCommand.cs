using Dynovert.Application.Geodesies.DTOs;

namespace Dynovert.Application.Geodesies.Commands.ConvertToGausKryuger;

public record ConvertToKryugerOrdinateCommand : IRequest<GeodesyGausKryugerDto>
{
    public ConvertToKryugerOrdinateCommand(ConvertToKryugerOrdinateCommand command)
    {
        Latitude = command.Latitude;
        Longitude = command.Longitude;
        CentralMeridian = command.CentralMeridian;
    }

    public string Latitude { get; set; } = string.Empty;
    public string Longitude { get; set; } = string.Empty;
    public string CentralMeridian { get; set; } = string.Empty;
}

public class ConvertToKryugerOrdinateCommandHandler : IRequestHandler<ConvertToKryugerOrdinateCommand, GeodesyGausKryugerDto>
{
    public Task<GeodesyGausKryugerDto> Handle(ConvertToKryugerOrdinateCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}