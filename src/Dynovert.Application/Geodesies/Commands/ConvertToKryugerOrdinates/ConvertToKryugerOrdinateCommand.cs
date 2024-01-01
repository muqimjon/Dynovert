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

    public static double ParseToSeconds(string param)
    {
        string[] parts = param.Split('°', '\'', '"');

        double degrees = double.Parse(parts[0]);
        double minutes = double.Parse(parts[1]);
        double seconds = double.Parse(parts[2].Replace(',', '.'));

        double totalSeconds = degrees * 3600 + minutes * 60 + seconds;
        return totalSeconds;
    }

    public static double ParseToRadians(string param)
    {
        string[] parts = param.Split('°', '\'', '"');

        double degrees = double.Parse(parts[0]);
        double minutes = double.Parse(parts[1]);
        double seconds = double.Parse(parts[2].Replace(',', '.'));

        double totalDegrees = degrees + minutes / 60 + seconds / 3600;
        double radians = totalDegrees * Math.PI / 180;

        return radians;
    }
}