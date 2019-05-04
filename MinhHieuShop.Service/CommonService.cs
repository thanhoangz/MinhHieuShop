using MinhHieuShop.Common;
using MinhHieuShop.Data.Infrastructure;
using MinhHieuShop.Data.Repositories;
using MinhHieuShop.Model.Models;
using System.Collections.Generic;

namespace MinhHieuShop.Service
{
    public interface ICommonService
    {
        Footer GetFooter();
        IEnumerable<Slide> GetSlides();
    }
    public class CommonService : ICommonService
    {
        IFooterRepository _footerRepository;
        IUnitOfWork _unitOfWork;
        ISlideRepository _slideRepository;
        public CommonService(IFooterRepository footerRepository, IUnitOfWork unitOfWork, ISlideRepository slideRepository)
        {
            _footerRepository = footerRepository;
            _unitOfWork = unitOfWork;
            _slideRepository = slideRepository;
        }
        public Footer GetFooter()
        {
            return _footerRepository.GetSingleByCondition(x => x.ID == CommonConstants.DefaultFooterId);
        }

        public IEnumerable<Slide> GetSlides()
        {
            return _slideRepository.GetMulti(x => x.Status);
        }
    }
}
