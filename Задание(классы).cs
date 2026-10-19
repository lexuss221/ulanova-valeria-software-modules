var master1 = new Masters();
Masters master2 = new();
Masters master3 = new();

var client1 = new Clients();
Clients client2 = new();
Clients client3 = new();

class Masters
{
    int master_id;
    string lastname;
    string name;
    string patronymic;
    string passport_details;
    int age;
    int work_exp;
    int salon_id;
    bool master_activity;
}

class Clients
{
    int client_id;
    string lastname;
    string name;
    int age;
}