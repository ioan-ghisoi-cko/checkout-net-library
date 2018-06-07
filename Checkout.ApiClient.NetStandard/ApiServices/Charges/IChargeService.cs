﻿using Checkout.ApiServices.Charges.RequestModels;
using Checkout.ApiServices.Charges.ResponseModels;
using Checkout.ApiServices.SharedModels;
using System.Threading.Tasks;

namespace Checkout.ApiServices.Charges
{
    public interface IChargeService
    {
        HttpResponse<Capture> CaptureCharge(string chargeId, ChargeCapture requestModel);
        HttpResponse<Charge> ChargeWithCard(CardCharge requestModel);
        HttpResponse<Charge> ChargeWithCardId(CardIdCharge requestModel);
        HttpResponse<Charge> ChargeWithCardToken(CardTokenCharge requestModel);
        HttpResponse<Charge> ChargeWithDefaultCustomerCard(DefaultCardCharge requestModel);
        HttpResponse<Charge> ChargeWithLocalPayment(LocalPaymentCharge requestModel);
        HttpResponse<Charge> GetCharge(string chargeId);
        HttpResponse<ChargeHistory> GetChargeHistory(string chargeId);
        HttpResponse<Refund> RefundCharge(string chargeId, ChargeRefund requestModel);
        HttpResponse<OkResponse> UpdateCharge(string chargeId, ChargeUpdate requestModel);
        HttpResponse<Charge> VerifyCharge(string paymentToken);
        HttpResponse<Void> VoidCharge(string chargeId, ChargeVoid requestModel);
    }

    public interface IChargeServiceAsync
    {
        Task<HttpResponse<Capture>> CaptureChargeAsync(string chargeId, ChargeCapture requestModel);
        Task<HttpResponse<Charge>> ChargeWithCardAsync(CardCharge requestModel);
        Task<HttpResponse<Charge>> ChargeWithCardIdAsync(CardIdCharge requestModel);
        Task<HttpResponse<Charge>> ChargeWithCardTokenAsync(CardTokenCharge requestModel);
        Task<HttpResponse<Charge>> ChargeWithDefaultCustomerCardAsync(DefaultCardCharge requestModel);
        Task<HttpResponse<Charge>> ChargeWithLocalPaymentAsync(LocalPaymentCharge requestModel);
        Task<HttpResponse<Charge>> GetChargeAsync(string chargeId);
        Task<HttpResponse<ChargeHistory>> GetChargeHistoryAsync(string chargeId);
        Task<HttpResponse<Refund>> RefundChargeAsync(string chargeId, ChargeRefund requestModel);
        Task<HttpResponse<OkResponse>> UpdateChargeAsync(string chargeId, ChargeUpdate requestModel);
        Task<HttpResponse<Charge>> VerifyChargeAsync(string paymentToken);
        Task<HttpResponse<Void>> VoidChargeAsync(string chargeId, ChargeVoid requestModel);
    }
}