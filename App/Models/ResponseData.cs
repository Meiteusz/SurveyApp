﻿namespace Models
{
    public class ResponseData<T> : Response
    {
        public T Data { get; set; }
    }
}
