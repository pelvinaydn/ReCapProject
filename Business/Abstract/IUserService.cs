﻿using Core.Entities.Concrete;
using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IUserService
    {
        List<OperationClaim> GetClaims(User user);
        User GetByMail(string email);

        IDataResult<List<User>> GetAll();
        IDataResult<User> GetUserById(int userId);
        IResult Add(User user);
        IResult Delete(User user);
        IResult Update(User user);

    }
}
