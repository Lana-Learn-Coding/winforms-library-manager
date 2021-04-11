namespace LibraryApplication.UI.Component
{
    public static class FormControlValidator
    {
        public delegate ControlError Validate(object val);

        public static readonly Validate Required = val =>
        {
            if (val is string s)
            {
                return string.IsNullOrWhiteSpace(s)
                    ? new ControlError {Message = "Field is required"}
                    : new ControlError {IsValid = false};
            }

            return NotNull(val);
        };

        public static readonly Validate NotNull = val => val == null
            ? new ControlError {Message = "Field is required"}
            : new ControlError {IsValid = false};
    }

    public class ControlError
    {
        public string Message { get; init; } = "";

        public bool IsValid { get; init; }
    }
}