﻿define([
	'base/base-object-grid-view',
    'collections/DriverLicenceMasterData/ExamClasses',
    'l!t!DriverLicenceMasterData/ExamClasses/FilterExamClasses',
    'l!t!DriverLicenceMasterData/ExamClasses/ExamClassesRelationships'
], function (BaseView, Collection, FilterView, DetailView) {
	'use strict';

	var view = BaseView.extend({

        collectionType: Collection,
        detailView: DetailView,
        filterView: FilterView,
	    tableName: 'examClass',	    
	    editUrl: '#ExamClasses',

	    editItemTitle: function () {
	        return this.resources.edit
	    },

		columns: function () {
		    return [
		        { field: 'name', title: this.resources.name, width: '70px' },
		        { field: 'description', title: this.resources.description },
		        { field: 'fromDate', title: this.resources.fromDate, format: '{0:d}' },
		        { field: 'toDate', title: this.resources.toDate, format: '{0:d}' },
		    ];
		}
	});

	return view;
});