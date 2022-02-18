using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities.Concrete;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IUserService
    {
        //kullanıcı roller getir
        IDataResult<List<OperationClaim>> GetClaims(User user);
        //kullanıcı ekle
        IResult Add(User user);
        // kullanıcı maile göre getir
        IDataResult<User> GetByMail(string email);
    }
}
