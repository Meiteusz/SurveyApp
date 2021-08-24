using Models;
using System.Collections.Generic;

namespace Controllers.Interfaces
{
    public interface IOccurrenceBLL
    {
        Occurrence Create();
        ResponseData<Occurrence> GetById(Occurrence occurrence);
        ResponseData<List<Occurrence>> GetAll();
        Response Delete(Occurrence occurrence);
    }
}
