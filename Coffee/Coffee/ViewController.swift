//
//  ViewController.swift
//  Coffee
//
//  Created by Jessica Alexander on 6/18/19.
//  Copyright © 2019 Jessica Alexander. All rights reserved.
//

import UIKit

class ViewController: UIViewController {
    var orders=["Coffee Order:"]
    var prices = [0.00]

    @IBOutlet weak var IcedSwitch: UISwitch!
    @IBOutlet weak var CupStack: UIStackView!
    @IBOutlet weak var MilkSwitch: UISwitch!
    @IBOutlet weak var SugarSwitch: UISwitch!
    @IBOutlet weak var DecafSwitch: UISwitch!
    @IBOutlet weak var OrderLabel: UILabel!
    override func viewDidLoad() {
        super.viewDidLoad()
        // Do any additional setup after loading the view.
            OrderLabel.text = "Coffee Order:"
    }
    @IBAction func AddCup(_ sender: UIButton) {
        let cupImage = UIImageView(image: UIImage(named: "RedCoffeeCup"))
        
        var order = ""
        var price = 0.00
        cupImage.contentMode = .scaleAspectFit
        UIView.animate(withDuration: 0.75, animations: {self.CupStack.addArrangedSubview(cupImage)
            self.CupStack.layoutIfNeeded()

        })
        
        if IcedSwitch.isOn{
            order += "\nIced Coffee"
            price += 3.52
        }
        else{
            order += "\nBlack Coffee"
            price += 2.35
        }
        if MilkSwitch.isOn{
            order += ", Milk"
            price += 0.75
        }
        if SugarSwitch.isOn{
            order += ", Sugar"
            price += 0.65
        }
        if DecafSwitch.isOn{
            order += ", Decaf"
        }
        prices += [price]
        orders += [order]
        order = ""
        
        OrderLabel.text = ""
        
        for index in 0 ... orders.count - 1{
            order = orders[index] + String(format: " $%.2f", prices[index])
            OrderLabel.text?.append(order)
        }
                }
        @IBAction func RemoveCup(_ sender: UIButton) {
            let LastAddedCup = self.CupStack.arrangedSubviews.last
            
            var order = ""
            if let cup = LastAddedCup
            {
                UIView.animate(withDuration: 0.25, animations: {self.CupStack.removeArrangedSubview(cup)
                    self.CupStack.layoutIfNeeded()
                })
                let LastIndex = orders.count - 1
                orders.remove(at: LastIndex)
                prices.remove(at: LastIndex)
                
                OrderLabel.text = ""
                
                for index in 0 ... orders.count - 1{
                    order = orders[index] + String(format: " $%.2f", prices[index])
                    OrderLabel.text?.append(order)
                }
                
            }
            
    }
    @IBAction func CompleteSale(_ sender: UIButton) {
        var TotalPrice = 0.00
        var order = ""
        
        
        for index in 0 ... orders.count - 1{
            TotalPrice += prices[index]
        }
        order = String(format: "Your total is $%.2f. Thank you!!", TotalPrice)
        OrderLabel.text?.append(order)
    }
}

