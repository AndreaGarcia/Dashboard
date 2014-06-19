using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de Usuarios
/// </summary>
public sealed class Usuario
{
    private static int _id;
    private static string _nombre;
    private static string _usuario;
    private static int _idRol;
    private static Rol _rol;
    private static object syncRoot;

    private static volatile Usuario usuario;

    private Usuario() { }

    public static Usuario UsuarioLogueado
    {
        get
        {
            if (usuario == null)
            {
                lock (syncRoot)
                {
                    if (usuario == null)
                        usuario = new Usuario();
                }
            }

            return usuario;
        }
    }

    public static int Identificacion
    {
        get
        {
            return _id;
        }
    }

    public static string NombreUsuario
    {
        get
        {
            return _usuario;
        }
    }

    public static string Nombre
    {
        get
        {
            return _nombre;
        }
    }

    public static int IdRol
    {
        get
        {
            return _idRol;
        }
    }

    public static Rol Rol
    {
        get
        {
            return _rol;
        }
    }

    public static void IniciarValores
        (
        int id,
        string usuario,
        string nombre,
        int idRol
        )
    {
        _id = id;
        _usuario = usuario;
        _nombre = nombre;
        _idRol = idRol;
        ParseAEnum(idRol);
    }

    private static void ParseAEnum(int idRol)
    {

        switch (idRol)
        {
            case 1: _rol = global::Rol.Administrador; break;
            case 2: _rol = global::Rol.Generador; break;
            case 3: _rol = global::Rol.Concesionario; break;
            case 4: _rol = global::Rol.OperadorServicio; break;
            case 5: _rol = global::Rol.OperadorRecaudo; break;
            case 6: _rol = global::Rol.Autorizador; break;
            case 7: _rol = global::Rol.Fideicomiso; break;
        }
    }
}