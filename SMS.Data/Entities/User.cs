﻿
namespace SMS.Data.Entities;

public enum Role { admin, support, guest }

public class User {
    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public Role Role { get; set; }

}

