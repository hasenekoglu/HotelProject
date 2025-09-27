using HotelProject.BusinessLayer.Abstarct;
using HotelProject.DataAccessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;

namespace HotelProject.BusinessLayer.Concrete;

public class ServiceManager : IServiceService
{
    private readonly IServicesDal _ServiceDal;

    public ServiceManager(IServicesDal ServiceDal)
    {
        _ServiceDal=ServiceDal;
    }

    public void TDelete(Service t)
    {
       _ServiceDal.Delete(t);
    }

    public Service TGetById(int id)
    {
        return _ServiceDal.GetById(id);
    }

    public List<Service> TGetList()
    {
        return _ServiceDal.GetList();
    }

    public void TInsert(Service t)
    {
        _ServiceDal.Insert(t);
    }

    public void TUpdate(Service t)
    {
       _ServiceDal.Update(t);
    }
}

