using System;
using AutoMapper;
using Finanseed.Application.Interfaces;
using Finanseed.Application.ViewModels;
using Finanseed.Domain.Base.Interfaces;
using Finanseed.Domain.Commands;
using Finanseed.Domain.Repositories;

namespace Finanseed.Application.Services
{
    public class UserAppService : IUserAppService
    {
        private readonly IUserRepository _repository;
        private readonly IMapper _mapper;

        private readonly IHandler<RegisterUserCommand> _handler;
        public UserAppService(IUserRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
        public UserViewModel RegisterUser(UserViewModel registerViewModel)
        {
            var command = _mapper.Map<RegisterUserCommand>(registerViewModel);
            var result = _handler.Handle(command);
            return _mapper.Map<UserViewModel>(result);
        }
        public UserViewModel GetUser(Guid userId)
        {
            return _mapper.Map<UserViewModel>(_repository.GetById(userId));
        }
    }
}