pipeline {
	agent none
	
	environment {
		VAL = 'ola'
		BRANCHNAME = $(BRANCH_NAME)
	}
	
	stages {
		stage('pre') {
			steps {
				echo 'NO BRANCH MAIN'
			}
		}
		stage('pre2') {
			when {
				branch "main"
			}
			steps {
				script {
				    if (env.VAL == ola) {
					echo 'igual'
				    } else {
					echo 'diferente'
				    }
				}
			}
		}
		stage('checkout') {
			agent any
			steps {
				echo 'checkout do BRANCH->$(env.BRANCHNAME)'
				checkout sm
			}		
		}
		stage('build') {
			steps {
				echo '$(BUILD_ID)->$(JOB_NAME):$(BUILD_NAME)'
			}
		}
	}
	
	post {
		success {
			echo 'Sucesso'
		}
	}
}


