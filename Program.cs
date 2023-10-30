namespace Hospital_Management;
// Patient class for patient details
public class Patient
{
    public int PatientId { get; set; }
    public string Name { get; set; }
    public string Address { get; set; }
}

// Doctor class for doctor details
public class Doctor
{
    public int DoctorId { get; set; }
    public string Name { get; set; }
    public string Specialization { get; set; }
}
public class Appointment
{
    public int AppointmentId { get; set; }
    public int PatientId { get; set; }
    public int DoctorId { get; set; }
    public DateTime AppointmentDateTime { get; set; }
}

// Billing class for managing billing details
public class Billing
{
    public int BillingId { get; set; }
    public int PatientId { get; set; }
    public decimal Amount { get; set; }
    public DateTime BillingDate { get; set; }
}

// HospitalManagementSystem class to manage the system's functionalities
public class HospitalManagementSystem
{
    private List<Patient> patients = new List<Patient>();
    private List<Doctor> doctors = new List<Doctor>();
    private List<Appointment> appointments = new List<Appointment>();
    private List<Billing> billings = new List<Billing>();

    // Method to add a patient
    public void AddPatient(Patient patient)
    {
        patients.Add(patient);
    }

    // Method to add a doctor
    public void AddDoctor(Doctor doctor)
    {
        doctors.Add(doctor);
    }

    // Method to schedule an appointment
    public void ScheduleAppointment(Appointment appointment)
    {
        appointments.Add(appointment);
    }
    // Method to add a billing record
    public void AddBilling(Billing billing)
    {
        billings.Add(billing);
    }
}
    class Program
    {
        static void Main(string[] args)
        {
        //Examples
        HospitalManagementSystem hospitalSystem = new HospitalManagementSystem();

        // Adding a patient
        Patient patient1 = new Patient { PatientId = 1, Name = "John Doe",
            Address = "123 Main St" };
        hospitalSystem.AddPatient(patient1);

        // Adding a doctor
        Doctor doctor1 = new Doctor { DoctorId = 1,
            Name = "Dr. Smith", Specialization = "Cardiology" };
        hospitalSystem.AddDoctor(doctor1);

        // Scheduling an appointment
        Appointment appointment1 = new Appointment { AppointmentId = 1,
            PatientId = 1, DoctorId = 1, AppointmentDateTime = DateTime.Now };
        hospitalSystem.ScheduleAppointment(appointment1);

        // Adding a billing record
        Billing billing1 = new Billing { BillingId = 1,
            PatientId = 1, Amount = 150.50m, BillingDate = DateTime.Now };
        hospitalSystem.AddBilling(billing1);
        }
    }


