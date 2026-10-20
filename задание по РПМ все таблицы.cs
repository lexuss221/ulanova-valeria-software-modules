namespace Задание_по_РПМ
{
    class Masters
    {
        public int master_id;
        public string lastname;
        public string name;
        public string patronymic;
        public string passport_details;
        public int age;
        public int work_exp;
        public Salon salon_id;
        public bool master_activity;
    }

    class Clients
    {
        public int client_id;
        public string lastname;
        public string name;
        public int age;
    }

    class Access
    {
        public int access_id;
        public Masters master_id;
        public Services service_id;
        public DateOnly access_date;
    }

    class Registration
    {
        public int registration_id;
        public DateTime date_create;
        public Clients client_id;
        public string registartion_status;
    }

    class Registration_position
    {
        public Registration registration_id;
        public int position_num;
        public Resources resource_id;
        public Access access_id;
        public DateTime planned_start;
        public DateTime planned_end;
        public double position_agreed_price;
        public string position_status;


    }

    class Salon
    {
        public int salon_id;
        public string salon_name;
        public string salon_address;
        public char salon_OGRN;
        public char bank_account;
        public char salon_INN;
    }

    class Services
    {
        public int service_id;
        public string service_name;
        public double agreed_price;
        public bool cancel_fact;
    }

    class Resources
    {
        public int resource_id;
        public string resource_category;
        public string occupancy_status;
        public double resource_price;
        public Salon salon_id;
    }

    class Completion_fact
    {
        public Registration registration_id;
        public Registration_position position_num;
        public DateTime Starting;
        public DateTime Ending;
        public string result;
    }
}