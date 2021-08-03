namespace Models
{
    public class ResponseData<T> : Response
    {
        public T GetData { get; set; }
    }
}
