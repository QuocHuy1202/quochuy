#include <iostream>
using namespace std;

class Duck {
public:
    virtual void quack() = 0;
    virtual void swim() = 0;
    virtual void display() = 0;
};

class MallardDuck : public Duck {
public:
    void quack() override {
        cout << "can Quack!" << endl;
    }

    void swim() override {
        cout << "can Swim..." << endl;
    }
    void fly() {
        cout << "Can Fly..." << endl;
    }
    void display() override {
        cout << "Displaying Mallard Duck." << endl;
        
        this->quack();
        this->swim();
        this->fly();
    }

    
};

class RedheadDuck : public Duck {
public:
    void quack() override {
        cout << "Can Quack!" << endl;
    }

    void swim() override {
        cout << "Can Swim..." << endl;
    }
    void fly() {
        cout << "Can Fly..." << endl;
    }
    void display() override {
        cout << "Displaying Redhead Duck." << endl;
         this->quack();
        this->swim();
        this->fly();
    }

    
};
class RubberDuck : public Duck {
public:
    void quack() override {
        cout << "Can Quack!" << endl;
    }

    void swim() override {
        cout << "Can Swim..." << endl;
    }
    void fly() {
        cout << "Can't Fly..." << endl;
    }
    void display() override {
        cout << "Displaying Rubber Duck." << endl;
         this->quack();
        this->swim();
        this->fly();
    }

    
};
int main() {
    MallardDuck mallardDuck;
    
    mallardDuck.display();
   

    RedheadDuck redheadDuck;
    
    redheadDuck.display();
    
    RubberDuck rubberDuck;
    rubberDuck.display();

    return 0;
}
