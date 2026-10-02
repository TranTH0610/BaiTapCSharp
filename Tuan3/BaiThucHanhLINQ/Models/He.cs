namespace BaiThucHanhLINQ.Models;

public class He
{
    public string MaHe { get; set; } = "";
    public string TenHe { get; set; } = "";

    public override string ToString()
    {
        return $"{MaHe,-5} | {TenHe}";
    }
}