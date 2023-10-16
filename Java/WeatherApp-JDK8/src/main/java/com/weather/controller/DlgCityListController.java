/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package com.weather.controller;

import com.google.gson.Gson;
import com.google.gson.stream.JsonReader;
import com.weather.pojo.City;
import java.io.FileNotFoundException;
import java.io.FileReader;
import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;
import javax.swing.DefaultListModel;

/**
 *
 * @author Wong
 */
public class DlgCityListController {

    public DlgCityListController() {
    }

    public List<City> getCityList() throws FileNotFoundException {
        Gson gson = new Gson();
        JsonReader reader = new JsonReader(new FileReader(getClass().getResource("/com/weather/json/city.list.json").getPath()));
        City[] data = gson.fromJson(reader, City[].class);
        return Arrays.asList(data);
    }

    public DefaultListModel getListModel() throws FileNotFoundException {
        DefaultListModel listModel = new DefaultListModel();
        getCityList().stream()
                .filter((city) -> city.getCountry().equals("NI"))
                .forEach((city) -> {
                    listModel.addElement(city.toString());
                });
        return listModel;
    }
    
    public List<String> getNICities() throws FileNotFoundException{
        List<String> cities = new ArrayList<>();
        getCityList().stream().filter((city)-> city.getCountry().equals("NI")).forEach((city) -> {
            cities.add(city.toString());
        });
        
        return cities;
    }
}
