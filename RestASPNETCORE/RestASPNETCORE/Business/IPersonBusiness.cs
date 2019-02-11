using RestASPNETCORE.Data.VO;
using System.Collections.Generic;
using Tapioca.HATEOAS.Utils;

namespace RestASPNETCORE.Business
{
    public interface IPersonBusiness
    {
        PersonVO Create(PersonVO person);
        PersonVO FindById(long Id);
        List<PersonVO> FindAll();
        List<PersonVO> FindByName(string firstname, string lastname);
        PersonVO Update(PersonVO person);
        void Delete(long Id);
        PagedSearchDTO<PersonVO> FindWithPagedSearch(string name, string sortDirection, int pageSize, int page);
    }
}
