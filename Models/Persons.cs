using System;

namespace astonesport.Models;

/// <summary>
/// Représente les informations d'une équipe
/// </summary>
public abstract class Person
{
    /// <summary>
    /// Obtient ou définit la date de création
    /// </summary>
    public DateTime Created { get; set; } = DateTime.UtcNow;

    /// <summary>
    /// Obtient ou définit la date de modification
    /// </summary>
    public DateTime Updated { get; set; }


    /// <summary>
    /// Obtient ou définit le prénom d'un joueur
    /// </summary>
    public string FisrtName { get; set; }


    /// <summary>
    /// Obtient ou définit le nom d'un joueur
    /// </summary>
    public string LastName { get; set; }

    /// <summary>
    /// Obtient ou définit le nom d'un joueur
    /// </summary>
    public string FullName { get; set; }

    /// <summary>
    /// Obtient ou définit le Role  d'un joueur
    /// </summary>
    public string Role { get; set; }

    /// <summary>
    /// Obtient ou définit la nationalité  d'un joueur
    /// </summary>
    public string Nationality { get; set; }


}

