using System;
using System.Collections.Generic;
using System.Text;

namespace AshkanCrm.Application.Interfaces
{
    public interface IUserService
    {
        Task<AshkanCrm.Domain.ViewModels.User.AddMarketerResult> AddMarketer(AshkanCrm.Domain.ViewModels.User.AddMarketerViewModel marketer);
    }
}
