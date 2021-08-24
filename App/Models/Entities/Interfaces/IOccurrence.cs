using System.Collections.Generic;

namespace Models.Entities.Interfaces
{
    public interface IOccurrence
    {
        ResponseData<Occurrence> GetById(Occurrence p_Occurrence);
        ResponseData<List<Occurrence>> GetAll();
        Response Delete(Occurrence p_Occurrence);
    }
}
