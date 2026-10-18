namespace QuanLyNguoiDung.Data
{
    public class LoiCoSoDuLieuException : Exception
    {
        public LoiCoSoDuLieuException(
            string thongBao,
            Exception? goc = null)
            : base(thongBao, goc)
        {
        }
    }
}