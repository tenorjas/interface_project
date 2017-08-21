using System;

namespace interface_project
{
    public interface ITankDriver
    {
        string GoForward();
        string Turn();
        string FireCannon();
    }
}