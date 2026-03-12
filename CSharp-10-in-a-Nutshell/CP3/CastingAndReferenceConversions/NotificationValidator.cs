namespace CSharp_10_in_a_Nutshell.CP3.CastingAndReferenceConversions;

public class NotificationValidator
{
    // Cast using operatore
    public void Validate(Notification notif)
    {
        if (notif is EmailNotification emailNotif)
        {
            if (!emailNotif.EmailAddress.Contains("@"))
                Console.WriteLine("Error: Invalid Email Format!");
        }
        else if (notif is SmsNotification)
        {
            SmsNotification? smsNotif = notif as SmsNotification;
            if (smsNotif!.PhoneNumber.Length < 10)
                Console.WriteLine("Error: Invalid Phone Number!");
        }
        else
        {
            Console.WriteLine("Generic Notification is OK.");
        }
    }
}