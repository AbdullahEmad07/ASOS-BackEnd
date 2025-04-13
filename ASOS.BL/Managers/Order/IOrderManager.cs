﻿using ASOS.BL.DTOs;

namespace ASOS.BL.Managers.Order
{
    public interface IOrderManager
    {
        Task<bool> CreateOrderAsync(Guid cartId, string address, string phoneNumber);
        Task<bool> CancelOrderAsync( Guid orderId);
        Task<bool> CompleteOrderAsync(string userId, Guid orderId);
        Task<List<OrderDTO>> GetUserOrdersAsync(string userId);
        Task<OrderDTO> GetOrderByIdAsync(Guid orderId);
    }
}
