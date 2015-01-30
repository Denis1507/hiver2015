using System;
using System.Web;
using System.Web.UI;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Owin;
using Site_de_la_Technique_Informatique.Models;

namespace Site_de_la_Technique_Informatique.Account
{
    public partial class ForgotPassword : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void Forgot(object sender, EventArgs e)
        {
            if (IsValid)
            {
                // Valider le mot de passe de l'utilisateur
                var manager = Context.GetOwinContext().GetUserManager<ApplicationUserManager>();
                ApplicationUser user = manager.FindByName(Email.Text);
                if (user == null || !manager.IsEmailConfirmed(user.Id))
                {
                    FailureText.Text = "L'utilisateur n'existe pas ou n'est pas confirmé.";
                    ErrorMessage.Visible = true;
                    return;
                }
                // Pour plus d'informations sur l'activation de la confirmation du compte et la réinitialisation du mot de passe, consultez  http://go.microsoft.com/fwlink/?LinkID=320771
                // Envoyer le courrier électronique avec le code et la redirection pour réinitialiser la page du mot de passe
                //string code = manager.GeneratePasswordResetToken(user.Id);
                //string callbackUrl = IdentityHelper.GetResetPasswordRedirectUrl(code);
                //manager.SendEmail(user.Id, "Réinitialiser le mot de passe", "Réinitialisez votre mot de passe en cliquant <a href=\"" + callbackUrl + "\">ici</a>.");
            }
        }
    }
}