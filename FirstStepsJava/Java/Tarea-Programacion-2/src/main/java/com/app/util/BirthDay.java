/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.app.util;

import java.time.LocalDate;
import java.time.Period;

/**
 *
 * @author Wong
 */
public class BirthDay {

    /**
     *
     */
    private BirthDay() {

    }

    /**
     *
     * @param text
     * @return
     */
    public static LocalDate getBirthDay(String text) {
        int day = Integer.parseInt(text.substring(4, 6));
        int month = Integer.parseInt(text.substring(6, 8));
        int year = Integer.parseInt(text.substring(8, 10));
        if (year >= 0 && year <= 4) {
            year += 2000;
        } else if (year >= 60 && year <= 99) {
            year += 1900;
        }
        return LocalDate.of(year, month, day);
    }

    /**
     *
     * @param text
     * @return
     */
    public static int getAge(String text) {
        return Period.between(getBirthDay(text), LocalDate.now()).getYears();
    }
}
