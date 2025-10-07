using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

public static class Verficacion
{
    public static bool ValidarTodo(
        ref TextBox txtNombre,
        ref TextBox txtApellido,
        ref TextBox txtCorreo,
        ref TextBox txtContraseña,
        ref ErrorProvider erpErrorNom,
        ref ErrorProvider erpErrorApe,
        ref ErrorProvider erpErrorCorreo,
        ref ErrorProvider erpErrorContraseña)
    {
        bool esValido = true;

        if (!ValidarTexto(txtNombre, erpErrorNom, "El nombre es obligatorio"))
            esValido = false;
        if (!ValidarTexto(txtApellido, erpErrorApe, "El apellido es obligatorio"))
            esValido = false;
        if (!ValidarCorreo(txtCorreo, erpErrorCorreo))
            esValido = false;
        if (!ValidarContraseña(txtContraseña, erpErrorContraseña))
            esValido = false;

        return esValido;
    }

    public static bool ValidarTexto(TextBox txtNomApe, ErrorProvider erpNomApe, string mensaje)
    {
        if (string.IsNullOrWhiteSpace(txtNomApe.Text))
        {
            erpNomApe.SetError(txtNomApe, mensaje);
            return false;
        }
        erpNomApe.SetError(txtNomApe, "");
        return true;
    }

    public static bool ValidarCorreo(TextBox txtCor, ErrorProvider erpCor)
    {
        string correo = txtCor.Text.Trim();
        List<string> errores = new List<string>();
        string[] dominios = { "@gmail.com", "@hotmail.com", "@utp.ac.pa" };
        bool dominioValido = dominios.Any(d => correo.EndsWith(d));
        int cantidadArrobas = correo.Count(c => c == '@');
        int posicionArroba = correo.IndexOf('@');

        if (string.IsNullOrEmpty(correo))
            errores.Add("El correo es obligatorio.");

        if (cantidadArrobas != 1)
            errores.Add("Debe contener exactamente un '@'.");

        if (posicionArroba < 1)
            errores.Add("Debe tener texto antes de '@'.");

        if (!dominioValido)
            errores.Add("El dominio del correo debe ser @gmail.com, @hotmail.com o @utp.ac.pa.");

        if (errores.Count > 0)
        {
            erpCor.SetError(txtCor, string.Join("\n", errores));
            return false;
        }

        erpCor.SetError(txtCor, "");
        return true;
    }

    public static bool ValidarContraseña(TextBox txtCon, ErrorProvider erpCon)
    {
        string contraseña = txtCon.Text;
        List<string> errores = new List<string>();

        if (contraseña.Length < 12)
            errores.Add("Debe tener al menos 12 caracteres.");
        if (!contraseña.Any(char.IsDigit))
            errores.Add("Debe contener al menos un dígito.");
        if (!contraseña.Any(char.IsUpper))
            errores.Add("Debe contener al menos una mayúscula.");
        if (!contraseña.Any(cn => "!@#$%^&*".Contains(cn)))
            errores.Add("Debe contener al menos un carácter especial (!@#$%^&*).");

        if (errores.Count > 0)
        {
            erpCon.SetError(txtCon, string.Join("\n", errores));
            return false;
        }

        erpCon.SetError(txtCon, "");
        return true;
    }
}