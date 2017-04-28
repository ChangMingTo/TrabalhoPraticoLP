using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Scrum.Models;

namespace Scrum.Controllers
{
    public class ScrumTeamController
    {
        private List<ScrumTeamController> teams;
        public ScrumTeamController()
        {
            teams = new List<ScrumTeamController>();
        }

        /// <summary>
        /// Adiciona Teams
        /// </summary>
        /// <param name="team"></param>
        /// <returns></returns>
        public bool AddTeam(ScrumTeamController team)
        {
            teams.Add(team);
            return true;
        }

        /// <summary>
        /// Remove Teams
        /// </summary>
        /// <param name="team"></param>
        /// <returns></returns>
        public bool RemoveTeam(ScrumTeamController team)
        {
            teams.Remove(team);
            return true;
        }

        /// <summary>
        /// Adiciona colaborados á team
        /// </summary>
        /// <param name="teamScrum"></param>
        /// <param name="add"></param>
        /// <returns></returns>
        public bool AddDeveloperToTeam(ScrumTeam teamScrum,Developer add)
        {
            if (teamScrum.Developers.Count > 9)
            {
                return false ;
            }
            else
            {
                teamScrum.Developers.Add(add);
                return true;
            }

        }

        //possibilidade de remover por nome, username, função, etc..
        /// <summary>
        /// Remove colaboradores, de uma team, pelo nome 
        /// </summary>
        /// <param name="teamScrum"></param>
        /// <param name="nome"></param>
        /// <returns></returns>
        public bool RemoveDeveloperFromTeamByName(ScrumTeam teamScrum, string nome)
        {
            bool last = false;
            foreach(Developer a in teamScrum.Developers)
            {
                if (a.Name == nome)
                {
                    teamScrum.Developers.Remove(a);
                    last= true;
                }
            }
            return last;
        }

        /// <summary>
        /// Remove um colaborador pesquisando pela sua função
        /// </summary>
        /// <param name="teamScrum"></param>
        /// <param name="funcao"></param>
        /// <returns></returns>
        public bool RemoveDeveloperFromTeamByUsername(ScrumTeam teamScrum, Function funcao)
        {
            bool a = false;
            foreach(Developer b in teamScrum.Developers)
            {
                if (b.Fuction == funcao)
                {
                    teamScrum.Developers.Remove(b);
                    a = true;
                }
            }
            return a;
        }

    }
}
