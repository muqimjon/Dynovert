namespace Dynovert.Application.Geodesies.DTOs;

public class GeodesyGausKryugerDto
{
    [DisplayName("B°")]
    public string LatitudeCorner { get; set; } = string.Empty;

    [DisplayName("B\'")]
    public double LatitudeSecond { get; set; }

    [DisplayName("B\"/ρ")]
    public double LatitudeSecondDivRadian { get; set; }

    [DisplayName("sin B")]
    public double SinusLatitude { get; set; }

    [DisplayName("cos B")]
    public double CosinusLatitude { get; set; }

    [DisplayName("cos² B")]
    public double CosinusPowLatitude { get; set; }

    [DisplayName("l°=L-L_0")]
    public string DistanceMinut { get; set; } = string.Empty;

    [DisplayName("l\"")]
    public double DistanceSecond { get; set; }

    [DisplayName("l=l\"/ρ")]
    public double Distance { get; set; }

    [DisplayName("N")]
    public double NPoint { get; set; }

    [DisplayName("a_0")]
    public double DirectionCorner { get; set; }

    [DisplayName("a_4")]
    public double DirectionCorner4 { get; set; }

    [DisplayName("a_6")]
    public double DirectionCorner6 { get; set; }

    [DisplayName("a_3")]
    public double DirectionCorner3 { get; set; }

    [DisplayName("a_5")]
    public double DirectionCorner5 { get; set; }

    [DisplayName("l²")]
    public double DistancePow { get; set; }

    [DisplayName("Nl²")]
    public double NDistancePow { get; set; }

    [DisplayName("X")]
    public string Abscissa { get; set; } = string.Empty;

    [DisplayName("Y")]
    public string Ordinate { get; set; } = string.Empty;
}

