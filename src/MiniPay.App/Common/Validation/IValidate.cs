﻿
namespace MiniPay
{
    public interface IValidate
    {
        ValidationResult Validate();
    }

    public interface IValidate<in T>
    {
        ValidationResult Validate(T obj);
    }
}
