/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.app.util;

/**
 *
 * @author Wong
 */
public class Validator {

    /**
     *
     */
    private static final String VALIDATE_ID_NUMBER_REGEX
            = "(?i)[0-9]{3}"
            + "\\-"
            + "(0[1-9]|1[0-9]|2[0-9]|3[0-1])"
            + "(0[1-9]|1[0-2])"
            + "(0[0-4]|6[0-9]|7[0-9]|8[0-9]|9[0-9])"
            + "\\-"
            + "[0-9]{4}"
            + "[A-Z]";

    /**
     *
     */
    private Validator() {

    }

    /**
     *
     * @param text
     * @return
     */
    public static boolean validateIDNumber(String text) {
        return text.matches(VALIDATE_ID_NUMBER_REGEX);
    }
}
