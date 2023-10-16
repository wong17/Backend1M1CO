/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.app.model;

import com.app.enums.Gender;
import java.io.Serializable;
import java.time.LocalDate;

/**
 *
 * @author Wong
 */
public class Person implements Serializable {

    /**
     *
     */
    private int personId;

    /**
     *
     */
    private String name;

    /**
     *
     */
    private String lastName;

    /**
     *
     */
    private String idNumber;

    /**
     *
     */
    private LocalDate birthDay;

    /**
     *
     */
    private int age;

    /**
     *
     */
    private Gender gender;

    /**
     *
     */
    private int departmentId;

    /**
     *
     */
    private int municipalityId;

    /**
     *
     */
    public Person() {
    }

    /**
     *
     * @return
     */
    public int getPersonId() {
        return personId;
    }

    /**
     *
     * @param personId
     */
    public void setPersonId(int personId) {
        this.personId = personId;
    }

    /**
     *
     * @return
     */
    public String getName() {
        return name;
    }

    /**
     *
     * @param name
     */
    public void setName(String name) {
        this.name = name;
    }

    /**
     *
     * @return
     */
    public String getLastName() {
        return lastName;
    }

    /**
     *
     * @param lastName
     */
    public void setLastName(String lastName) {
        this.lastName = lastName;
    }

    /**
     *
     * @return
     */
    public String getIdNumber() {
        return idNumber;
    }

    /**
     *
     * @param idNumber
     */
    public void setIdNumber(String idNumber) {
        this.idNumber = idNumber;
    }

    /**
     *
     * @return
     */
    public LocalDate getBirthDay() {
        return birthDay;
    }

    /**
     *
     * @param birthDay
     */
    public void setBirthDay(LocalDate birthDay) {
        this.birthDay = birthDay;
    }

    /**
     *
     * @return
     */
    public int getAge() {
        return age;
    }

    /**
     *
     * @param age
     */
    public void setAge(int age) {
        this.age = age;
    }

    /**
     *
     * @return
     */
    public Gender getGender() {
        return gender;
    }

    /**
     *
     * @param gender
     */
    public void setGender(Gender gender) {
        this.gender = gender;
    }

    /**
     *
     * @return
     */
    public int getDepartmentId() {
        return departmentId;
    }

    /**
     *
     * @param departmentId
     */
    public void setDepartmentId(int departmentId) {
        this.departmentId = departmentId;
    }

    /**
     *
     * @return
     */
    public int getMunicipalityId() {
        return municipalityId;
    }

    /**
     *
     * @param municipalityId
     */
    public void setMunicipalityId(int municipalityId) {
        this.municipalityId = municipalityId;
    }

    /**
     *
     * @return
     */
    @Override
    public String toString() {
        return "Person{" + "personId=" + personId + ", name=" + name
                + ", lastName=" + lastName + ", idNumber=" + idNumber
                + ", birthDay=" + birthDay + ", age=" + age
                + ", gender=" + gender + ", departmentId=" + departmentId
                + ", municipalityId=" + municipalityId + '}';
    }

}
