using System;

namespace astonesport.Models;

/// <summary>
/// Représente les informations d'une équipe
/// </summary>
public class Team
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
    /// Obtient ou définit le nom d'une équipe
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Obtient ou définit le nom d'une équipe
    /// </summary>
    public string[] Area { get; set; }

    /// <summary>
    /// Obtient ou définit la liste des joueurs
    /// </summary>
    public Roster[] Rosters { get; set; }

    /// <summary>
    /// Obtient ou définit la liste des remplaçants
    /// </summary>
    public Player[] Substitute { get; set; }

    /// <summary>
    /// Obtient ou définit le nom d'une équipe
    /// </summary>
    public Person[] Coach { get; set; }

    public class Roster
    {
        /// <summary>
        /// Obtient ou définit la liste des remplaçants
        /// </summary>
        public Player[] Players { get; set; }
    }
}

