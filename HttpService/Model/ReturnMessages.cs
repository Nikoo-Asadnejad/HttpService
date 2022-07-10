namespace HttpService.Model;

  public struct ReturnMessages
  {
    public const string SuccessMessage = "عملیات با موفقعیت انجام شد";
    public const string CreatedMessage = "رکورد مورد نظر با موفقعیت اضافه شد";
    public const string NotFoundMessage = "دیتای مورد نظر یافت نشد";
    public const string InternalServerErrorMessage = "خطای سرور";
    public const string DuplicationErrorMessage = "داده ورودی تکراری است";
    public const string InvalidInputErrorMessage = "داده ورودی نا معتبر است";
    public const string BadRequestErrorMessage = "خطایی در دریافت اطلاعات رخ داده است";
  }

