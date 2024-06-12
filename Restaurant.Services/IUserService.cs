﻿using Restaurant.Shared.Request;
using Restaurant.Shared.Response;

namespace Restaurant.Services;

public interface IUserService
{
    Task<LoginDTOResponse> LoginAsync(LoginDTORequest request);
    Task<BaseResponse> RegisterAsyn(RegistrarUsuarioDTO request);
}
