using System.ComponentModel.DataAnnotations;
using HopeChurchWeb.Models;
using Microsoft.AspNetCore.Components;
using MudBlazor;

namespace HopeChurchWeb.Components.Pages.Login;

public partial class ForgetPassword : ComponentBase
{
    #region [Inject]

    [Inject] private IDialogService _dialogService { get; set; } = null!;

    #endregion

    #region [Variable]

    // MudStepper component
    private MudStepper _stepper = null!;
    private int _stepIndex;
    private bool _isCompleted = false;

    // form model
    private ForgetPasswordVerification _passwordVerification = new();
    private PasswordReset _passwordReset = new();

    // button password type component
    private bool _showMainPassword = false;
    private bool _showSubPassword = false;
    private string _mainPasswordInputIcon = Icons.Material.Filled.VisibilityOff;
    private string _subPasswordInputIcon = Icons.Material.Filled.VisibilityOff;
    private InputType _mainPasswordInputType = InputType.Password;
    private InputType _subPasswordInputType = InputType.Password;

    #endregion

    private async Task HandlePreviousStepClickAsync()
    {
        await _stepper.PreviousStepAsync();
    }

    private async Task HandleNextStepClickAsync()
    {
        switch (_stepIndex)
        {
            case 0:
            {
                var (Results, message) = VerifyForgetPasswordVerification(_passwordVerification);
                if (Results)
                    await _stepper.NextStepAsync();
                else
                    await _dialogService.ShowMessageBox("錯誤", message);
            }
                break;
            case 1:
            {
                var (Results, message) = VerifyPasswordReset(_passwordReset);
                if (Results)
                    await _stepper.NextStepAsync();
                else
                    await _dialogService.ShowMessageBox("錯誤", message);
            }
                break;
            case 2:
            {
            }
                break;
        }
    }

    private (bool, string) ValidateObject<T>(T obj) where T : class
    {
        ValidationContext context = new(obj);
        List<ValidationResult> results = [];
        var isValid = Validator.TryValidateObject(obj, context, results, true);
        if (!isValid) return (false, results.First().ErrorMessage ?? string.Empty);

        return (true, string.Empty);
    }

    private (bool, string) VerifyForgetPasswordVerification(ForgetPasswordVerification form)
    {
        return ValidateObject(form);
    }

    private (bool, string) VerifyPasswordReset(PasswordReset password)
    {
        return ValidateObject(password);
    }

    private void HandleMainPasswordInputIconClick()
    {
        HandlePasswordInputIconProcessing(true);
    }

    private void HandleSubPasswordInputIconClick()
    {
        HandlePasswordInputIconProcessing(false);
    }

    private void HandlePasswordInputIconProcessing(bool isMainPassword)
    {
        if (isMainPassword)
        {
            _showMainPassword = !_showMainPassword;
            _mainPasswordInputIcon =
                _showMainPassword ? Icons.Material.Filled.VisibilityOff : Icons.Material.Filled.Visibility;
            _mainPasswordInputType = _showMainPassword ? InputType.Password : InputType.Text;
        }
        else
        {
            _showSubPassword = !_showSubPassword;
            _subPasswordInputIcon =
                _showSubPassword ? Icons.Material.Filled.VisibilityOff : Icons.Material.Filled.Visibility;
            _subPasswordInputType = _showSubPassword ? InputType.Password : InputType.Text;
        }
    }
}