using Company.Business.Abstract;
using Company.DataAccess.DataContext;
using Company.Entity.Concrete;

namespace Company.Business.Concrete
{
    public class PersonelManager : IPersonelService
    {
        private readonly CompanyContext _companyContext;

        public PersonelManager(CompanyContext companyContext)
        {
            _companyContext = companyContext;
        }

        public void Add(Personel entity)
        {
            var isPersonelExist = _companyContext.Personels.FirstOrDefault(x => x.No == entity.No);

            if (isPersonelExist == null)
            {
                _companyContext.Personels.Add(entity);
                _companyContext.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            var isPersonelExist = GetById(id);
            if (isPersonelExist is not null)
            {
                _companyContext.Personels.Remove(isPersonelExist);
                _companyContext.SaveChanges();
            }
        }

        public Personel GetById(int id)
        {
            var getPersonel = _companyContext.Personels.FirstOrDefault(x => x.Id == id);
            return getPersonel;
        }

        public List<Personel> GetList()
        {
            var getPersonelList = _companyContext.Personels.ToList();
            return getPersonelList;
        }

        public void Update(Personel entity)
        {
            _companyContext.Personels.Update(entity);
            _companyContext.SaveChanges();
        }
    }
}
