using System.Collections.Generic;

namespace Models.Entities.Interfaces
{
    public interface IOccurrence
    {
        Response Insert(Occurrence p_Occurrence);
        Response Delete(Occurrence p_Occurrence);
        ResponseData<IEnumerable<dynamic>> GetAll();
        ResponseData<Occurrence> GetById(Occurrence p_Occurrence);
        ResponseData<IEnumerable<dynamic>> GetByFilters();
    }
}
