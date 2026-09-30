namespace BaiThucHanhLINQ.Models;

public class MonHoc
{
    public string MaMon { get; set; } = "";
    public string TenMon { get; set; } = "";
    public string He { get; set; } = "";
    public byte SoTiet { get; set; }

    public override string ToString()
    {
        return $"{MaMon,-8} | {TenMon,-45} | {He,-4} | {SoTiet,3} tiết";
    }
}